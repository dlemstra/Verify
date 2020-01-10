using System;
using System.Collections.Generic;

namespace Verify
{
    public partial class VerifySettings
    {
        internal List<Func<string, string>> instanceScrubbers = new List<Func<string, string>>();

        public VerifySettings ScrubMachineName()
        {
            AddScrubber(Scrubbers.ScrubMachineName);
            return this;
        }

        public VerifySettings AddScrubber(Func<string, string> scrubber)
        {
            Guard.AgainstNull(scrubber, nameof(scrubber));

            instanceScrubbers.Insert(0, scrubber);
            return this;
        }

        public void ScrubLinesContaining(StringComparison comparison, params string[] stringToMatch)
        {
            instanceScrubbers.Insert(0, s => s.RemoveLinesContaining(comparison, stringToMatch));
            return this;
        }

        public VerifySettings ScrubLines(Func<string, bool> removeLine)
        {
            instanceScrubbers.Insert(0, s => s.FilterLines(removeLine));
            return this;
        }

        public VerifySettings ScrubLinesWithReplace(Func<string, string> replaceLine)
        {
            instanceScrubbers.Insert(0, s => s.ReplaceLines(replaceLine));
            return this;
        }

        public VerifySettings ScrubLinesContaining(params string[] stringToMatch)
        {
            ScrubLinesContaining(StringComparison.OrdinalIgnoreCase, stringToMatch);
            return this;
        }
    }
}