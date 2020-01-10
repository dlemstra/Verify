namespace Verify
{
    public partial class VerifySettings
    {
        internal bool clipboardEnabled = true;

        public VerifySettings DisableClipboard()
        {
            clipboardEnabled = false;
            return this;
        }
    }
}