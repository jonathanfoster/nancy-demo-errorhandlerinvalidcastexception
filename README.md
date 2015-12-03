# Nancy Error Handler Invalid Cast Exception Demo

This repo is used to reproduce [Nancy](https://github.com/NancyFx/Nancy) issue [#2122](https://github.com/NancyFx/Nancy/issues/2122). 

To reproduce the issue you need to create a view that inherits from `NancyRazorViewBase<T>` and explicitly negotiate the view with a model that throws an exception (e.g. `Negotiate.WithView('Index').WithModel(new BadModel());`). When the exception is thrown the `DefaultStatusCodeHandler` will attempt to negotiate content with the `DefaultStatusCodeHandlerResult` model and the `NancyRazorViewBase<T>` and produce an invalid cast exception. This issue occurs because the `DefaultStatusCodeHandler` does not reset the negotiation context on error.

## Getting Started

1. Run the `Nancy.Demo.ErrorHandlerInvalidCastException` project in Visual Studio
2. Confirm a YSOD that reads `Unable to cast object of type 'DefaultStatusCodeHandlerResult' to type 'Nancy.Demo.ErrorHandling.Models.User'`