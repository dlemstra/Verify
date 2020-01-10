using System;
using Newtonsoft.Json;
using Verify;
using VerifyXunit;
using Xunit.Abstractions;

public class Snippets: VerifyBase
{
    void DisableClipboard()
    {
        #region DisableClipboard

        Verify("content", new VerifySettings().DisableClipboard());

        #endregion
    }

    void AutoVerify()
    {
        #region AutoVerify

        Verify("content", new VerifySettings().AutoVerify());
        #endregion
    }

    void DisableDiff()
    {
        #region DisableDiff

        var settings = new VerifySettings();
        settings.DisableDiff();

        #endregion
    }

    void ApplyExtraSettingsSample()
    {
        #region ExtraSettings

        var settings = new VerifySettings();
        settings.AddExtraSettings(_ =>
        {
            _.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            _.TypeNameHandling = TypeNameHandling.All;
        });

        #endregion
    }

    public void ScopedSerializer()
    {
        #region ScopedSerializer

        var person = new Person
        {
            GivenNames = "John",
            FamilyName = "Smith",
            Dob = new DateTimeOffset(2000, 10, 1, 0, 0, 0, TimeSpan.Zero),
        };
        var settings = new VerifySettings();
        settings.ModifySerialization(
            _ => _.DontScrubDateTimes());
        settings.AddExtraSettings(
            _ => { _.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat; });

        #endregion
    }

    public Snippets(ITestOutputHelper output) :
        base(output)
    {
    }
}