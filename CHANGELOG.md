## [1.0.0-beta.0](https://github.com/auth0/auth0-aspnetcore-mvc/tree/v1.0.0-beta.0) (2021-05-27)

**Install**

```
Install-Package Auth0.AspNetCore.Mvc -IncludePrerelease
```

**Usage**

Integrate the SDK in your ASP.NET Core application by calling `AddAuth0WebAppAuthentication` in your `Startup.ConfigureService` method:

```csharp
services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = Configuration["Auth0:Domain"];
    options.ClientId = Configuration["Auth0:ClientId"];
});
```

**Added**

- Implement Basic Cookie & OpenIdConnect Authentication [#7](https://github.com/auth0/auth0-aspnetcore-mvc/pull/7) ([frederikprijck](https://github.com/frederikprijck))
- Support configuring the Scopes [#8](https://github.com/auth0/auth0-aspnetcore-mvc/pull/8) ([frederikprijck](https://github.com/frederikprijck))
- Support configuring the callback path [#9](https://github.com/auth0/auth0-aspnetcore-mvc/pull/9) ([frederikprijck](https://github.com/frederikprijck))
- Add builder for AuthenticationProperties [#11](https://github.com/auth0/auth0-aspnetcore-mvc/pull/11) ([frederikprijck](https://github.com/frederikprijck))
- Configure Auth0 logout URL [#10](https://github.com/auth0/auth0-aspnetcore-mvc/pull/10) ([frederikprijck](https://github.com/frederikprijck))
- Support custom parameters [#12](https://github.com/auth0/auth0-aspnetcore-mvc/pull/12) ([frederikprijck](https://github.com/frederikprijck))
- Configure User Agent [#15](https://github.com/auth0/auth0-aspnetcore-mvc/pull/15) ([frederikprijck](https://github.com/frederikprijck))
- Support Audience [#13](https://github.com/auth0/auth0-aspnetcore-mvc/pull/13) ([frederikprijck](https://github.com/frederikprijck))
- Save tokens to be able to retrieve them [#17](https://github.com/auth0/auth0-aspnetcore-mvc/pull/17) ([frederikprijck](https://github.com/frederikprijck)
- Use Implicit flow instead of Code flow [#21](https://github.com/auth0/auth0-aspnetcore-mvc/pull/21) ([frederikprijck](https://github.com/frederikprijck))
- Re-add support for Code Flow to be able to retrieve Access Tokens [#22](https://github.com/auth0/auth0-aspnetcore-mvc/pull/22) ([frederikprijck](https://github.com/frederikprijck)
- Support Refresh Tokens [#31](https://github.com/auth0/auth0-aspnetcore-mvc/pull/31) ([frederikprijck](https://github.com/frederikprijck)
- Proxy all OpenId Connect Events [#34](https://github.com/auth0/auth0-aspnetcore-mvc/pull/34) ([frederikprijck](https://github.com/frederikprijck)
- Rework to move Access Token to `WithAccessToken()` [#35](https://github.com/auth0/auth0-aspnetcore-mvc/pull/35) ([frederikprijck](https://github.com/frederikprijck)
- Rework Extra Parameters and support logout endpoint [#37](https://github.com/auth0/auth0-aspnetcore-mvc/pull/37) ([frederikprijck](https://github.com/frederikprijck)
