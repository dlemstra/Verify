﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Verify;

namespace VerifyMSTest
{
    public partial class VerifyBase
    {
        public async Task Verify<T>(
            Task<T> task,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "")
        {
            using var verifier = BuildVerifier(sourceFile, settings);
            await verifier.Verify(task, settings);
        }
        public async Task Verify<T>(
            IAsyncEnumerable<T> enumerable,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "")
        {
            using var verifier = BuildVerifier(sourceFile, settings);
            await verifier.Verify(enumerable, settings);
        }

        public async Task Verify<T>(
            T target,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "")
        {
            using var verifier = BuildVerifier(sourceFile, settings);
            await verifier.Verify(target, settings);
        }
    }
}