using System;
using System.Reflection;

namespace aspentech_APSIntegrationDemo_v9.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}