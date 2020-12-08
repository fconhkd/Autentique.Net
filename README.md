# Autentique.Net

![Travis-CI](https://travis-ci.org/lmestrinare/Autentique.Net.svg?branch=master)

An unofficial .NET API Wrapper for the Autentique (https://www.autentique.com.br/).

## Installation
### Stable (NuGet)
Our stable builds available from NuGet through the Autentique.Net metapackage:
- [Autentique.Net](https://www.nuget.org/packages/Autentique.Net/)

## Compiling
In order to compile Autentique.Net, you require the following:

### Using Visual Studio
- [Visual Studio 2019](https://visualstudio.microsoft.com/)
- [.NET Framework SDK](https://dotnet.microsoft.com/download/dotnet-framework)

The .NET Core workload must be selected during Visual Studio installation.

## Known Issues

## Versioning Guarantees

This library generally abides by [Semantic Versioning](https://semver.org). Packages are published in MAJOR.MINOR.PATCH version format.

An increment of the PATCH component always indicates that an internal-only change was made, generally a bugfix. These changes will not affect the public-facing API in any way, and are always guaranteed to be forward- and backwards-compatible with your codebase, any pre-compiled dependencies of your codebase.

An increment of the MINOR component indicates that some addition was made to the library, and this addition is not backwards-compatible with prior versions. However, Autentique.Net **does not guarantee forward-compatibility** on minor additions. In other words, we permit a limited set of breaking changes on a minor version bump.

Due to the nature of the Autentique API, we will oftentimes need to add a property to an entity to support the latest API changes. Autentique.Net provides interfaces as a method of consuming entities; and as such, introducing a new field to an entity is technically a breaking change. Major version bumps generally indicate some major change to the library, and as such we are hesitant to bump the major version for every minor addition to the library. To compromise, we have decided that interfaces should be treated as **consumable only**, and your applications should typically not be implementing interfaces. (For applications where interfaces are implemented, such as in test mocks, we apologize for this inconsistency with SemVer).

Furthermore, while we will never break the API (outside of interface changes) on minor builds, we will occasionally need to break the ABI, by introducing parameters to a method to match changes upstream with Discord. As such, a minor version increment may require you to recompile your code, and dependencies, such as addons, may also need to be recompiled and republished on the newer version. When a binary breaking change is made, the change will be noted in the release notes.

An increment of the MAJOR component indicates that breaking changes have been made to the library; consumers should check the release notes to determine what changes need to be made.
