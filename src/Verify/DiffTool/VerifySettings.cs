namespace Verify
{
    public partial class VerifySettings
    {
        internal bool diffEnabled = true;

        public VerifySettings DisableDiff()
        {
            diffEnabled = false;
            return this;
        }
    }
}