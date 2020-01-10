using System;
using Newtonsoft.Json;

namespace Verify
{
    public partial class VerifySettings
    {
        internal SerializationSettings serialization = SharedVerifySettings.serialization;
        bool isCloned;

        public VerifySettings ModifySerialization(Action<SerializationSettings> action)
        {
            if (!isCloned)
            {
                serialization = serialization.Clone();
                isCloned = true;
            }

            action(serialization);
            serialization.RegenSettings();
            return this;
        }

        public VerifySettings AddExtraSettings(Action<JsonSerializerSettings> action)
        {
            if (!isCloned)
            {
                serialization = serialization.Clone();
                isCloned = true;
            }

            serialization.AddExtraSettings(action);
            serialization.RegenSettings();
            return this;
        }
    }
}