using Plugin.BluetoothLE;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WearConduit.Shared.Models.MiBand3
{
    public static class Authentication
    {
        private const int ChallengeHeaderLength = 3;
        private const int ChallengePayloadLength = 16;

        private static byte[] StaticEncryptionKey { get; } = Enumerable.Repeat<byte>(43, 16).ToArray();

        public static Task<bool> AuthenticateAsync(IDevice device)
        {
            var tcs = new TaskCompletionSource<bool>();

            var getCharacteristicDisposable = default(IDisposable);
            getCharacteristicDisposable = device.GetKnownCharacteristics(Resources.GuidServiceAuth, new Guid[] { Resources.GuidCharacteristicAuth }).Subscribe(async d =>
            {
                getCharacteristicDisposable.Dispose();
                getCharacteristicDisposable = null;

                if (d == null)
                {
                    tcs.SetResult(false);
                    return;
                }
                else
                {
                    var notifyCharacteristicDisposable = default(IDisposable);
                    notifyCharacteristicDisposable = d.RegisterAndNotify().Subscribe(async e =>
                    {
                        var data = e.Data;
                        if (data == null)
                        {
                            notifyCharacteristicDisposable.Dispose();
                            tcs.SetResult(false);
                            return;
                        }

                        //Check if response is valid
                        if (data[0] == Resources.AuthResponse && data[2] == Resources.AuthSuccess)
                        {
                            if (data[1] == Resources.AuthSendKey)
                            {
                                await RequestChallenge(d);
                            }
                            else if (data[1] == Resources.AuthRequestRandomAuthNumber)
                            {
                                await SendChallengeResponse(d, data);
                            }
                            else if (data[1] == Resources.AuthSendEncryptedAuthNumber)
                            {
                                notifyCharacteristicDisposable.Dispose();
                                tcs.SetResult(true);
                                return;
                            }
                        }
                        else
                        {
                            notifyCharacteristicDisposable.Dispose();
                            tcs.SetResult(false);
                            return;
                        }
                    },
                    exception =>
                    {
                        notifyCharacteristicDisposable.Dispose();
                        tcs.SetResult(false);
                        return;
                    });

                    await RequestChallenge(d);
                    /*if (_miBand3.SecretKey == null)
                    {
                        //Triggers vibration on device
                        await SetupSharedEncryptionKey(d);
                    }
                    else
                    {
                        //Continues session with authorization-number
                        await RequestChallenge(d);
                    }*/
                }
            });

            return tcs.Task;
        }

        private static async Task SetupSharedEncryptionKey(IGattCharacteristic authCharacteristic)
        {
            var responseHeader = new byte[] { 0x01, 0x00 };
            var response = new byte[responseHeader.Length + StaticEncryptionKey.Length];
            Buffer.BlockCopy(responseHeader, 0, response, 0, responseHeader.Length);
            Buffer.BlockCopy(StaticEncryptionKey, 0, response, responseHeader.Length, StaticEncryptionKey.Length);
            await authCharacteristic.WriteWithoutResponse(response);
        }

        private static async Task RequestChallenge(IGattCharacteristic authCharacteristic)
        {
            var payload = new byte[Resources.RequestNumber.Length];
            Resources.RequestNumber.CopyTo(payload);
            await authCharacteristic.WriteWithoutResponse(payload);
        }

        private static async Task SendChallengeResponse(IGattCharacteristic authCharacteristic, byte[] challenge)
        {
            var challengePayload = new byte[ChallengePayloadLength];
            Buffer.BlockCopy(challenge, ChallengeHeaderLength, challengePayload, 0, challengePayload.Length);
            var responsePayload = Encrypt(StaticEncryptionKey, challengePayload);

            var responseHeader = new byte[] { 0x03, 0x00 };
            var response = new byte[responseHeader.Length + responsePayload.Length];
            Buffer.BlockCopy(responseHeader, 0, response, 0, responseHeader.Length);
            Buffer.BlockCopy(responsePayload, 0, response, responseHeader.Length, responsePayload.Length);
            await authCharacteristic.WriteWithoutResponse(response);
        }

        private static byte[] Encrypt(byte[] key, byte[] plaintext)
        {
            var encryptor = new AesManaged()
            {
                Mode = CipherMode.ECB,
                Key = key,
                Padding = PaddingMode.None,
            }.CreateEncryptor();

            return encryptor.TransformFinalBlock(plaintext, 0, plaintext.Length);
        }
    }
}
