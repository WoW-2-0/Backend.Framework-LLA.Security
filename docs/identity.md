# Identity

## In this documentation

- [About identity](#overview)
- [Types of identity](#types-of-identity)
- [Useful packages list](#useful-packages)
- [Examples](#examples)

## Prerequisites

- [Asp.NET Core 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [PostgresSQL](https://www.postgresql.org/download/)

## Overview

Identity is about

### What Identity Secures:

- **user authentication** - validates user identities using credentials and possibly multi-factor authentication.
- **user authorization** - manages user access to resources based on roles or claims.
- **data protection** -  secures sensitive data by controlling access and enforcing encryption.
- **audit and compliance** - tracks user activities and ensures adherence to legal/regulatory standards.
- **session management** - manages user sessions securely, including handling session expiration and protection.

### How identity achieves it

- **credential storage and verification** - securely stores and verifies user credentials without exposing sensitive data.
- **role-based access control (rbac)** - assigns permissions based on user roles to simplify and enhance security.
- **token-based authentication** - uses tokens (like jwt) for secure authentication and carrying user claims.
- **oauth and openid connect** - implements standards for secure delegated access and identity verification.
- **security policies and protocols** - enforces security measures like password policies and secure data transmission.
- **two-factor/multi-factor authentication** - adds additional verification layers to enhance security.
- **api security** - protects api endpoints from unauthorized access and misuse.

You can find more information in this documentation - [link](https://sultonbek-rakhimov.notion.site/Identity-4aac78d00c0c475ba0dde8f3d94f0ded?pvs=4)

## Types of Identity



## Local Identity


## Cloud Identity


- ASP.NET Core 7 or later
- Basic understanding of ASP.NET Core Identity
- Familiarity with JWT standards

## Useful packages

- **Microsoft.AspNetCore.Identity**
    - Core framework for implementing identity in ASP.NET Core applications.
    - [Microsoft.AspNetCore.Identity](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity)

- **Microsoft.AspNetCore.Authentication.JwtBearer**
    - Adds JWT (JSON Web Token) bearer token support to an ASP.NET Core application.
    - [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer)

- **Microsoft.AspNetCore.Authentication.OAuth**
    - Supports OAuth 2.0 authentication providers like Google, Facebook, Twitter.
    - [Microsoft.AspNetCore.Authentication.OAuth](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.OAuth)

- **Microsoft.AspNetCore.Authentication.OpenIdConnect**
    - For integrating OpenID Connect authentication.
    - [Microsoft.AspNetCore.Authentication.OpenIdConnect](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.OpenIdConnect)

- **IdentityServer4**
    - Framework for implementing OpenID Connect and OAuth 2.0.
    - [IdentityServer4](https://www.nuget.org/packages/IdentityServer4)

- **Microsoft.IdentityModel.Tokens**
    - Provides classes for creating and validating security tokens.
    - [Microsoft.IdentityModel.Tokens](https://www.nuget.org/packages/Microsoft.IdentityModel.Tokens)

  - **Microsoft.Extensions.Identity.Stores**
      - Extensions for custom storage providers for the Identity system.
      - [Microsoft.Extensions.Identity.Stores](https://www.nuget.org/packages/Microsoft.Extensions.Identity.Stores)

- **Microsoft.AspNetCore.Identity.EntityFrameworkCore**
    - Integrates ASP.NET Core Identity with Entity Framework Core.
    - [Microsoft.AspNetCore.Identity.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity.EntityFrameworkCore)

- **System.IdentityModel.Tokens.Jwt**
    - For creating and validating JSON Web Tokens.
    - [System.IdentityModel.Tokens.Jwt](https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt)

- **Microsoft.AspNetCore.Authentication.Cookies**
    - Supports cookie-based authentication.
    - [Microsoft.AspNetCore.Authentication.Cookies](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.Cookies)

- **Duende IdentityServer** (formerly IdentityServer4)
    - Commercial version of IdentityServer4 with enhanced features and support.
    - [Duende IdentityServer](https://www.duendesoftware.com/products/identityserver)

- **Microsoft.AspNetCore.Authentication.AzureAD.UI**
    - Simplifies Azure Active Directory authentication integration.
    - [Microsoft.AspNetCore.Authentication.AzureAD.UI](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.AzureAD.UI)

## Examples



- [Simple JWT Authentication](../src/Identity.Local.Schemes.Jwt/README.md)



