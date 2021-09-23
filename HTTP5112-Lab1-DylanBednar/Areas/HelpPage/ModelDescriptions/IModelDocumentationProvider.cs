using System;
using System.Reflection;

namespace HTTP5112_Lab1_DylanBednar.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}