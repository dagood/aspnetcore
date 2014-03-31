// <auto-generated />
namespace Microsoft.AspNet.Mvc.Core
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Mvc.Core.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The provided identity of type '{0}' is marked IsAuthenticated = true but does not have a value for Name. By default, the anti-forgery system requires that all authenticated identities have a unique Name. If it is not possible to provide a unique Name for this identity, consider extending IAdditionalDataProvider by overriding the DefaultAdditionalDataProvider or a custom type that can provide some form of unique identifier for the current user.
        /// </summary>
        internal static string TokenValidator_AuthenticatedUserWithoutUsername
        {
            get { return GetString("TokenValidator_AuthenticatedUserWithoutUsername"); }
        }

        /// <summary>
        /// The provided identity of type '{0}' is marked IsAuthenticated = true but does not have a value for Name. By default, the anti-forgery system requires that all authenticated identities have a unique Name. If it is not possible to provide a unique Name for this identity, consider extending IAdditionalDataProvider by overriding the DefaultAdditionalDataProvider or a custom type that can provide some form of unique identifier for the current user.
        /// </summary>
        internal static string FormatTokenValidator_AuthenticatedUserWithoutUsername(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TokenValidator_AuthenticatedUserWithoutUsername"), p0);
        }

        /// <summary>
        /// A claim of type '{0}' was not present on the provided ClaimsIdentity.
        /// </summary>
        internal static string ClaimUidExtractor_ClaimNotPresent
        {
            get { return GetString("ClaimUidExtractor_ClaimNotPresent"); }
        }

        /// <summary>
        /// A claim of type '{0}' was not present on the provided ClaimsIdentity.
        /// </summary>
        internal static string FormatClaimUidExtractor_ClaimNotPresent(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ClaimUidExtractor_ClaimNotPresent"), p0);
        }

        /// <summary>
        /// A claim of type 'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier' or 'http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider' was not present on the provided ClaimsIdentity. To enable anti-forgery token support with claims-based authentication, please verify that the configured claims provider is providing both of these claims on the ClaimsIdentity instances it generates. If the configured claims provider instead uses a different claim type as a unique identifier, it can be configured by setting the static property AntiForgeryConfig.UniqueClaimTypeIdentifier.
        /// </summary>
        internal static string ClaimUidExtractor_DefaultClaimsNotPresent
        {
            get { return GetString("ClaimUidExtractor_DefaultClaimsNotPresent"); }
        }

        /// <summary>
        /// A claim of type 'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier' or 'http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider' was not present on the provided ClaimsIdentity. To enable anti-forgery token support with claims-based authentication, please verify that the configured claims provider is providing both of these claims on the ClaimsIdentity instances it generates. If the configured claims provider instead uses a different claim type as a unique identifier, it can be configured by setting the static property AntiForgeryConfig.UniqueClaimTypeIdentifier.
        /// </summary>
        internal static string FormatClaimUidExtractor_DefaultClaimsNotPresent()
        {
            return GetString("ClaimUidExtractor_DefaultClaimsNotPresent");
        }

        /// <summary>
        /// The method '{0}' on type '{1}' returned an instance of '{2}'. Make sure to call Unwrap on the returned value to avoid unobserved faulted Task.
        /// </summary>
        internal static string ActionExecutor_WrappedTaskInstance
        {
            get { return GetString("ActionExecutor_WrappedTaskInstance"); }
        }

        /// <summary>
        /// The method '{0}' on type '{1}' returned an instance of '{2}'. Make sure to call Unwrap on the returned value to avoid unobserved faulted Task.
        /// </summary>
        internal static string FormatActionExecutor_WrappedTaskInstance(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ActionExecutor_WrappedTaskInstance"), p0, p1, p2);
        }

        /// <summary>
        /// The method '{0}' on type '{1}' returned a Task instance even though it is not an asynchronous method.
        /// </summary>
        internal static string ActionExecutor_UnexpectedTaskInstance
        {
            get { return GetString("ActionExecutor_UnexpectedTaskInstance"); }
        }

        /// <summary>
        /// The method '{0}' on type '{1}' returned a Task instance even though it is not an asynchronous method.
        /// </summary>
        internal static string FormatActionExecutor_UnexpectedTaskInstance(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ActionExecutor_UnexpectedTaskInstance"), p0, p1);
        }

        /// <summary>
        /// The provided anti-forgery token failed a custom data check.
        /// </summary>
        internal static string AntiForgeryToken_AdditionalDataCheckFailed
        {
            get { return GetString("AntiForgeryToken_AdditionalDataCheckFailed"); }
        }

        /// <summary>
        /// The provided anti-forgery token failed a custom data check.
        /// </summary>
        internal static string FormatAntiForgeryToken_AdditionalDataCheckFailed()
        {
            return GetString("AntiForgeryToken_AdditionalDataCheckFailed");
        }

        /// <summary>
        /// The provided anti-forgery token was meant for a different claims-based user than the current user.
        /// </summary>
        internal static string AntiForgeryToken_ClaimUidMismatch
        {
            get { return GetString("AntiForgeryToken_ClaimUidMismatch"); }
        }

        /// <summary>
        /// The provided anti-forgery token was meant for a different claims-based user than the current user.
        /// </summary>
        internal static string FormatAntiForgeryToken_ClaimUidMismatch()
        {
            return GetString("AntiForgeryToken_ClaimUidMismatch");
        }

        /// <summary>
        /// The required anti-forgery cookie "{0}" is not present.
        /// </summary>
        internal static string AntiForgeryToken_CookieMissing
        {
            get { return GetString("AntiForgeryToken_CookieMissing"); }
        }

        /// <summary>
        /// The required anti-forgery cookie "{0}" is not present.
        /// </summary>
        internal static string FormatAntiForgeryToken_CookieMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_CookieMissing"), p0);
        }

        /// <summary>
        /// The anti-forgery token could not be decrypted. If this application is hosted by a Web Farm or cluster, ensure that all machines are running the same version of ASP.NET Web Pages and that the &lt;machineKey&gt; configuration specifies explicit encryption and validation keys. AutoGenerate cannot be used in a cluster.
        /// </summary>
        internal static string AntiForgeryToken_DeserializationFailed
        {
            get { return GetString("AntiForgeryToken_DeserializationFailed"); }
        }

        /// <summary>
        /// The anti-forgery token could not be decrypted. If this application is hosted by a Web Farm or cluster, ensure that all machines are running the same version of ASP.NET Web Pages and that the &lt;machineKey&gt; configuration specifies explicit encryption and validation keys. AutoGenerate cannot be used in a cluster.
        /// </summary>
        internal static string FormatAntiForgeryToken_DeserializationFailed()
        {
            return GetString("AntiForgeryToken_DeserializationFailed");
        }

        /// <summary>
        /// The required anti-forgery form field "{0}" is not present.
        /// </summary>
        internal static string AntiForgeryToken_FormFieldMissing
        {
            get { return GetString("AntiForgeryToken_FormFieldMissing"); }
        }

        /// <summary>
        /// The required anti-forgery form field "{0}" is not present.
        /// </summary>
        internal static string FormatAntiForgeryToken_FormFieldMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_FormFieldMissing"), p0);
        }

        /// <summary>
        /// The anti-forgery cookie token and form field token do not match.
        /// </summary>
        internal static string AntiForgeryToken_SecurityTokenMismatch
        {
            get { return GetString("AntiForgeryToken_SecurityTokenMismatch"); }
        }

        /// <summary>
        /// The anti-forgery cookie token and form field token do not match.
        /// </summary>
        internal static string FormatAntiForgeryToken_SecurityTokenMismatch()
        {
            return GetString("AntiForgeryToken_SecurityTokenMismatch");
        }

        /// <summary>
        /// Validation of the provided anti-forgery token failed. The cookie "{0}" and the form field "{1}" were swapped.
        /// </summary>
        internal static string AntiForgeryToken_TokensSwapped
        {
            get { return GetString("AntiForgeryToken_TokensSwapped"); }
        }

        /// <summary>
        /// Validation of the provided anti-forgery token failed. The cookie "{0}" and the form field "{1}" were swapped.
        /// </summary>
        internal static string FormatAntiForgeryToken_TokensSwapped(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_TokensSwapped"), p0, p1);
        }

        /// <summary>
        /// The provided anti-forgery token was meant for user "{0}", but the current user is "{1}".
        /// </summary>
        internal static string AntiForgeryToken_UsernameMismatch
        {
            get { return GetString("AntiForgeryToken_UsernameMismatch"); }
        }

        /// <summary>
        /// The provided anti-forgery token was meant for user "{0}", but the current user is "{1}".
        /// </summary>
        internal static string FormatAntiForgeryToken_UsernameMismatch(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_UsernameMismatch"), p0, p1);
        }

        /// <summary>
        /// The anti-forgery system has the configuration value AntiForgeryConfig.RequireSsl = true, but the current request is not an SSL request.
        /// </summary>
        internal static string AntiForgeryWorker_RequireSSL
        {
            get { return GetString("AntiForgeryWorker_RequireSSL"); }
        }

        /// <summary>
        /// The anti-forgery system has the configuration value AntiForgeryConfig.RequireSsl = true, but the current request is not an SSL request.
        /// </summary>
        internal static string FormatAntiForgeryWorker_RequireSSL()
        {
            return GetString("AntiForgeryWorker_RequireSSL");
        }

        /// <summary>
        /// The class ReflectedActionFilterEndPoint only supports ReflectedActionDescriptors.
        /// </summary>
        internal static string ReflectedActionFilterEndPoint_UnexpectedActionDescriptor
        {
            get { return GetString("ReflectedActionFilterEndPoint_UnexpectedActionDescriptor"); }
        }

        /// <summary>
        /// The class ReflectedActionFilterEndPoint only supports ReflectedActionDescriptors.
        /// </summary>
        internal static string FormatReflectedActionFilterEndPoint_UnexpectedActionDescriptor()
        {
            return GetString("ReflectedActionFilterEndPoint_UnexpectedActionDescriptor");
        }

        /// <summary>
        /// The view component name '{0}' matched multiple types: {1}
        /// </summary>
        internal static string ViewComponent_AmbiguousTypeMatch
        {
            get { return GetString("ViewComponent_AmbiguousTypeMatch"); }
        }

        /// <summary>
        /// The view component name '{0}' matched multiple types: {1}
        /// </summary>
        internal static string FormatViewComponent_AmbiguousTypeMatch(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_AmbiguousTypeMatch"), p0, p1);
        }

        /// <summary>
        /// The async view component method '{0}' should be declared to return Task&lt;T&gt;.
        /// </summary>
        internal static string ViewComponent_AsyncMethod_ShouldReturnTask
        {
            get { return GetString("ViewComponent_AsyncMethod_ShouldReturnTask"); }
        }

        /// <summary>
        /// The async view component method '{0}' should be declared to return Task&lt;T&gt;.
        /// </summary>
        internal static string FormatViewComponent_AsyncMethod_ShouldReturnTask(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_AsyncMethod_ShouldReturnTask"), p0);
        }

        /// <summary>
        /// A view component must return a non-null value.
        /// </summary>
        internal static string ViewComponent_MustReturnValue
        {
            get { return GetString("ViewComponent_MustReturnValue"); }
        }

        /// <summary>
        /// A view component must return a non-null value.
        /// </summary>
        internal static string FormatViewComponent_MustReturnValue()
        {
            return GetString("ViewComponent_MustReturnValue");
        }

        /// <summary>
        /// The view component method '{0}' should be declared to return a value.
        /// </summary>
        internal static string ViewComponent_SyncMethod_ShouldReturnValue
        {
            get { return GetString("ViewComponent_SyncMethod_ShouldReturnValue"); }
        }

        /// <summary>
        /// The view component method '{0}' should be declared to return a value.
        /// </summary>
        internal static string FormatViewComponent_SyncMethod_ShouldReturnValue(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_SyncMethod_ShouldReturnValue"), p0);
        }

        /// <summary>
        /// A view component named '{0}' could not be found.
        /// </summary>
        internal static string ViewComponent_CannotFindComponent
        {
            get { return GetString("ViewComponent_CannotFindComponent"); }
        }

        /// <summary>
        /// A view component named '{0}' could not be found.
        /// </summary>
        internal static string FormatViewComponent_CannotFindComponent(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_CannotFindComponent"), p0);
        }

        /// <summary>
        /// An invoker could not be created for the view component '{0}'.
        /// </summary>
        internal static string ViewComponent_IViewComponentFactory_ReturnedNull
        {
            get { return GetString("ViewComponent_IViewComponentFactory_ReturnedNull"); }
        }

        /// <summary>
        /// An invoker could not be created for the view component '{0}'.
        /// </summary>
        internal static string FormatViewComponent_IViewComponentFactory_ReturnedNull(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_IViewComponentFactory_ReturnedNull"), p0);
        }

        /// <summary>
        /// Could not find an '{0}' method matching the parameters.
        /// </summary>
        internal static string ViewComponent_CannotFindMethod
        {
            get { return GetString("ViewComponent_CannotFindMethod"); }
        }

        /// <summary>
        /// Could not find an '{0}' method matching the parameters.
        /// </summary>
        internal static string FormatViewComponent_CannotFindMethod(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_CannotFindMethod"), p0);
        }

        /// <summary>
        /// Could not find an '{0}' or '{1}' method matching the parameters.
        /// </summary>
        internal static string ViewComponent_CannotFindMethod_WithFallback
        {
            get { return GetString("ViewComponent_CannotFindMethod_WithFallback"); }
        }

        /// <summary>
        /// Could not find an '{0}' or '{1}' method matching the parameters.
        /// </summary>
        internal static string FormatViewComponent_CannotFindMethod_WithFallback(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_CannotFindMethod_WithFallback"), p0, p1);
        }

        /// <summary>
        /// View components only support returning {0}, {1} or {2}.
        /// </summary>
        internal static string ViewComponent_InvalidReturnValue
        {
            get { return GetString("ViewComponent_InvalidReturnValue"); }
        }

        /// <summary>
        /// View components only support returning {0}, {1} or {2}.
        /// </summary>
        internal static string FormatViewComponent_InvalidReturnValue(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewComponent_InvalidReturnValue"), p0, p1, p2);
        }

        /// <summary>
        /// Replacing the action context is not supported.
        /// </summary>
        internal static string ActionContextAccessor_SetValueNotSupported
        {
            get { return GetString("ActionContextAccessor_SetValueNotSupported"); }
        }

        /// <summary>
        /// Replacing the action context is not supported.
        /// </summary>
        internal static string FormatActionContextAccessor_SetValueNotSupported()
        {
            return GetString("ActionContextAccessor_SetValueNotSupported");
        }

        /// <summary>
        /// An action invoker could not be created for action '{0}'.
        /// </summary>
        internal static string ActionInvokerFactory_CouldNotCreateInvoker
        {
            get { return GetString("ActionInvokerFactory_CouldNotCreateInvoker"); }
        }

        /// <summary>
        /// An action invoker could not be created for action '{0}'.
        /// </summary>
        internal static string FormatActionInvokerFactory_CouldNotCreateInvoker(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ActionInvokerFactory_CouldNotCreateInvoker"), p0);
        }

        /// <summary>
        /// The action descriptor must be of type '{0}'.
        /// </summary>
        internal static string DefaultControllerFactory_ActionDescriptorMustBeReflected
        {
            get { return GetString("DefaultControllerFactory_ActionDescriptorMustBeReflected"); }
        }

        /// <summary>
        /// The action descriptor must be of type '{0}'.
        /// </summary>
        internal static string FormatDefaultControllerFactory_ActionDescriptorMustBeReflected(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DefaultControllerFactory_ActionDescriptorMustBeReflected"), p0);
        }

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
        {
            return GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string PropertyOfTypeCannotBeNull
        {
            get { return GetString("PropertyOfTypeCannotBeNull"); }
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyOfTypeCannotBeNull"), p0, p1);
        }

        /// <summary>
        /// The '{0}' must return a non-null '{1}'.
        /// </summary>
        internal static string MethodMustReturnNotNullValue
        {
            get { return GetString("MethodMustReturnNotNullValue"); }
        }

        /// <summary>
        /// The '{0}' must return a non-null '{1}'.
        /// </summary>
        internal static string FormatMethodMustReturnNotNullValue(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MethodMustReturnNotNullValue"), p0, p1);
        }

        /// <summary>
        /// The supplied route values are ambiguous and can select multiple sets of actions.
        /// </summary>
        internal static string ActionSelector_GetCandidateActionsIsAmbiguous
        {
            get { return GetString("ActionSelector_GetCandidateActionsIsAmbiguous"); }
        }

        /// <summary>
        /// The supplied route values are ambiguous and can select multiple sets of actions.
        /// </summary>
        internal static string FormatActionSelector_GetCandidateActionsIsAmbiguous()
        {
            return GetString("ActionSelector_GetCandidateActionsIsAmbiguous");
        }

        /// <summary>
        /// Property '{0}' is of type '{1}', but this method requires a value of type '{2}'.
        /// </summary>
        internal static string ArgumentPropertyUnexpectedType
        {
            get { return GetString("ArgumentPropertyUnexpectedType"); }
        }

        /// <summary>
        /// Property '{0}' is of type '{1}', but this method requires a value of type '{2}'.
        /// </summary>
        internal static string FormatArgumentPropertyUnexpectedType(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyUnexpectedType"), p0, p1, p2);
        }

        /// <summary>
        /// The partial view '{0}' was not found or no view engine supports the searched locations. The following locations were searched:{1}
        /// </summary>
        internal static string Common_PartialViewNotFound
        {
            get { return GetString("Common_PartialViewNotFound"); }
        }

        /// <summary>
        /// The partial view '{0}' was not found or no view engine supports the searched locations. The following locations were searched:{1}
        /// </summary>
        internal static string FormatCommon_PartialViewNotFound(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Common_PartialViewNotFound"), p0, p1);
        }

        /// <summary>
        /// The value '{0}' is invalid.
        /// </summary>
        internal static string Common_ValueNotValidForProperty
        {
            get { return GetString("Common_ValueNotValidForProperty"); }
        }

        /// <summary>
        /// The value '{0}' is invalid.
        /// </summary>
        internal static string FormatCommon_ValueNotValidForProperty(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Common_ValueNotValidForProperty"), p0);
        }

        /// <summary>
        /// False
        /// </summary>
        internal static string Common_TriState_False
        {
            get { return GetString("Common_TriState_False"); }
        }

        /// <summary>
        /// False
        /// </summary>
        internal static string FormatCommon_TriState_False()
        {
            return GetString("Common_TriState_False");
        }

        /// <summary>
        /// Not Set
        /// </summary>
        internal static string Common_TriState_NotSet
        {
            get { return GetString("Common_TriState_NotSet"); }
        }

        /// <summary>
        /// Not Set
        /// </summary>
        internal static string FormatCommon_TriState_NotSet()
        {
            return GetString("Common_TriState_NotSet");
        }

        /// <summary>
        /// True
        /// </summary>
        internal static string Common_TriState_True
        {
            get { return GetString("Common_TriState_True"); }
        }

        /// <summary>
        /// True
        /// </summary>
        internal static string FormatCommon_TriState_True()
        {
            return GetString("Common_TriState_True");
        }

        /// <summary>
        /// ViewData value must not be null.
        /// </summary>
        internal static string DynamicViewData_ViewDataNull
        {
            get { return GetString("DynamicViewData_ViewDataNull"); }
        }

        /// <summary>
        /// ViewData value must not be null.
        /// </summary>
        internal static string FormatDynamicViewData_ViewDataNull()
        {
            return GetString("DynamicViewData_ViewDataNull");
        }

        /// <summary>
        /// The expression compiler was unable to evaluate the indexer expression '{0}' because it references the model parameter '{1}' which is unavailable.
        /// </summary>
        internal static string ExpressionHelper_InvalidIndexerExpression
        {
            get { return GetString("ExpressionHelper_InvalidIndexerExpression"); }
        }

        /// <summary>
        /// The expression compiler was unable to evaluate the indexer expression '{0}' because it references the model parameter '{1}' which is unavailable.
        /// </summary>
        internal static string FormatExpressionHelper_InvalidIndexerExpression(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ExpressionHelper_InvalidIndexerExpression"), p0, p1);
        }

        /// <summary>
        /// The IModelMetadataProvider was unable to provide metadata for expression '{0}'.
        /// </summary>
        internal static string HtmlHelper_NullModelMetadata
        {
            get { return GetString("HtmlHelper_NullModelMetadata"); }
        }

        /// <summary>
        /// The IModelMetadataProvider was unable to provide metadata for expression '{0}'.
        /// </summary>
        internal static string FormatHtmlHelper_NullModelMetadata(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("HtmlHelper_NullModelMetadata"), p0);
        }

        /// <summary>
        /// Must call 'Contextualize' method before using this HtmlHelper instance.
        /// </summary>
        internal static string HtmlHelper_NotContextualized
        {
            get { return GetString("HtmlHelper_NotContextualized"); }
        }

        /// <summary>
        /// Must call 'Contextualize' method before using this HtmlHelper instance.
        /// </summary>
        internal static string FormatHtmlHelper_NotContextualized()
        {
            return GetString("HtmlHelper_NotContextualized");
        }

        /// <summary>
        /// There is no ViewData item of type '{0}' that has the key '{1}'.
        /// </summary>
        internal static string HtmlHelper_MissingSelectData
        {
            get { return GetString("HtmlHelper_MissingSelectData"); }
        }

        /// <summary>
        /// There is no ViewData item of type '{0}' that has the key '{1}'.
        /// </summary>
        internal static string FormatHtmlHelper_MissingSelectData(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("HtmlHelper_MissingSelectData"), p0, p1);
        }

        /// <summary>
        /// The parameter '{0}' must evaluate to an IEnumerable when multiple selection is allowed.
        /// </summary>
        internal static string HtmlHelper_SelectExpressionNotEnumerable
        {
            get { return GetString("HtmlHelper_SelectExpressionNotEnumerable"); }
        }

        /// <summary>
        /// The parameter '{0}' must evaluate to an IEnumerable when multiple selection is allowed.
        /// </summary>
        internal static string FormatHtmlHelper_SelectExpressionNotEnumerable(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("HtmlHelper_SelectExpressionNotEnumerable"), p0);
        }

        /// <summary>
        /// The ViewData item that has the key '{0}' is of type '{1}' but must be of type '{2}'.
        /// </summary>
        internal static string HtmlHelper_WrongSelectDataType
        {
            get { return GetString("HtmlHelper_WrongSelectDataType"); }
        }

        /// <summary>
        /// The ViewData item that has the key '{0}' is of type '{1}' but must be of type '{2}'.
        /// </summary>
        internal static string FormatHtmlHelper_WrongSelectDataType(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("HtmlHelper_WrongSelectDataType"), p0, p1, p2);
        }

        /// <summary>
        /// The '{0}' template was used with an object of type '{1}', which does not implement '{2}'.
        /// </summary>
        internal static string Templates_TypeMustImplementIEnumerable
        {
            get { return GetString("Templates_TypeMustImplementIEnumerable"); }
        }

        /// <summary>
        /// The '{0}' template was used with an object of type '{1}', which does not implement '{2}'.
        /// </summary>
        internal static string FormatTemplates_TypeMustImplementIEnumerable(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Templates_TypeMustImplementIEnumerable"), p0, p1, p2);
        }

        /// <summary>
        /// Templates can be used only with field access, property access, single-dimension array index, or single-parameter custom indexer expressions.
        /// </summary>
        internal static string TemplateHelpers_TemplateLimitations
        {
            get { return GetString("TemplateHelpers_TemplateLimitations"); }
        }

        /// <summary>
        /// Templates can be used only with field access, property access, single-dimension array index, or single-parameter custom indexer expressions.
        /// </summary>
        internal static string FormatTemplateHelpers_TemplateLimitations()
        {
            return GetString("TemplateHelpers_TemplateLimitations");
        }

        /// <summary>
        /// Unable to locate an appropriate template for type {0}.
        /// </summary>
        internal static string TemplateHelpers_NoTemplate
        {
            get { return GetString("TemplateHelpers_NoTemplate"); }
        }

        /// <summary>
        /// Unable to locate an appropriate template for type {0}.
        /// </summary>
        internal static string FormatTemplateHelpers_NoTemplate(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TemplateHelpers_NoTemplate"), p0);
        }

        /// <summary>
        /// The model item passed is null, but this ViewDataDictionary instance requires a non-null model item of type '{0}'.
        /// </summary>
        internal static string ViewData_ModelCannotBeNull
        {
            get { return GetString("ViewData_ModelCannotBeNull"); }
        }

        /// <summary>
        /// The model item passed is null, but this ViewDataDictionary instance requires a non-null model item of type '{0}'.
        /// </summary>
        internal static string FormatViewData_ModelCannotBeNull(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewData_ModelCannotBeNull"), p0);
        }

        /// <summary>
        /// The model item passed into the ViewDataDictionary is of type '{0}', but this ViewDataDictionary instance requires a model item of type '{1}'.
        /// </summary>
        internal static string ViewData_WrongTModelType
        {
            get { return GetString("ViewData_WrongTModelType"); }
        }

        /// <summary>
        /// The model item passed into the ViewDataDictionary is of type '{0}', but this ViewDataDictionary instance requires a model item of type '{1}'.
        /// </summary>
        internal static string FormatViewData_WrongTModelType(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewData_WrongTModelType"), p0, p1);
        }

        /// <summary>
        /// No route matches the supplied values.
        /// </summary>
        internal static string NoRoutesMatched
        {
            get { return GetString("NoRoutesMatched"); }
        }

        /// <summary>
        /// No route matches the supplied values.
        /// </summary>
        internal static string FormatNoRoutesMatched()
        {
            return GetString("NoRoutesMatched");
        }

        /// <summary>
        /// If an {0} provides a result value by setting the {1} property of {2} to a non-null value, then it cannot call the next filter by invoking {3}.
        /// </summary>
        internal static string AsyncActionFilter_InvalidShortCircuit
        {
            get { return GetString("AsyncActionFilter_InvalidShortCircuit"); }
        }

        /// <summary>
        /// If an {0} provides a result value by setting the {1} property of {2} to a non-null value, then it cannot call the next filter by invoking {3}.
        /// </summary>
        internal static string FormatAsyncActionFilter_InvalidShortCircuit(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AsyncActionFilter_InvalidShortCircuit"), p0, p1, p2, p3);
        }

        /// <summary>
        /// If an {0} cancels execution by setting the {1} property of {2} to 'true', then it cannot call the next filter by invoking {3}.
        /// </summary>
        internal static string AsyncResultFilter_InvalidShortCircuit
        {
            get { return GetString("AsyncResultFilter_InvalidShortCircuit"); }
        }

        /// <summary>
        /// If an {0} cancels execution by setting the {1} property of {2} to 'true', then it cannot call the next filter by invoking {3}.
        /// </summary>
        internal static string FormatAsyncResultFilter_InvalidShortCircuit(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AsyncResultFilter_InvalidShortCircuit"), p0, p1, p2, p3);
        }

        /// <summary>
        /// The partial view '{0}' was not found. The following locations were searched:{1}
        /// </summary>
        internal static string ViewEngine_PartialViewNotFound
        {
            get { return GetString("ViewEngine_PartialViewNotFound"); }
        }

        /// <summary>
        /// The partial view '{0}' was not found. The following locations were searched:{1}
        /// </summary>
        internal static string FormatViewEngine_PartialViewNotFound(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewEngine_PartialViewNotFound"), p0, p1);
        }

        /// <summary>
        /// The view '{0}' was not found. The following locations were searched:{1}.
        /// </summary>
        internal static string ViewEngine_ViewNotFound
        {
            get { return GetString("ViewEngine_ViewNotFound"); }
        }

        /// <summary>
        /// The view '{0}' was not found. The following locations were searched:{1}.
        /// </summary>
        internal static string FormatViewEngine_ViewNotFound(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewEngine_ViewNotFound"), p0, p1);
        }

        /// <summary>
        /// Unable to locate an implementation of IAuthorizationService.
        /// </summary>
        internal static string AuthorizeAttribute_AuthorizationServiceMustBeDefined
        {
            get { return GetString("AuthorizeAttribute_AuthorizationServiceMustBeDefined"); }
        }

        /// <summary>
        /// Unable to locate an implementation of IAuthorizationService.
        /// </summary>
        internal static string FormatAuthorizeAttribute_AuthorizationServiceMustBeDefined()
        {
            return GetString("AuthorizeAttribute_AuthorizationServiceMustBeDefined");
        }

        /// <summary>
        /// OnAuthorization is not implemented by this filter, use OnAuthorizationAsync instead.
        /// </summary>
        internal static string AuthorizeAttribute_OnAuthorizationNotImplemented
        {
            get { return GetString("AuthorizeAttribute_OnAuthorizationNotImplemented"); }
        }

        /// <summary>
        /// OnAuthorization is not implemented by this filter, use OnAuthorizationAsync instead.
        /// </summary>
        internal static string FormatAuthorizeAttribute_OnAuthorizationNotImplemented()
        {
            return GetString("AuthorizeAttribute_OnAuthorizationNotImplemented");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
