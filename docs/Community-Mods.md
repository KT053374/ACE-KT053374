# Community ACE Mods and Tools

A starting directory of publicly available community mods, extensions, examples, and related tools for [ACEmulator (ACE)](https://github.com/ACEmulator/ACE). This list is intended to make projects easier to find, not to recommend specific changes to an ACE server.

**Community-maintained listing:** Unless otherwise noted, these projects are maintained by their respective authors. Inclusion does not imply endorsement, testing, security review, support, or compatibility with any particular ACE version. Check each project's README, requirements, and releases before installing. Back up your server and test third-party mods outside production first.

Repositories were checked for public availability on **November 2, 2026**. Entries are not a comprehensive inventory and may become outdated.

## Community server mods

| Project | Maintainer / repository | Purpose |
| --- | --- | --- |
| [ACEStatsDiscord](https://github.com/KT053374/ACEStatsDiscord) | KT053374 | Publishes an online character roster, player count, and server status to Discord. |
| [AutoLoot](https://github.com/Raajik/AutoLoot) | Raajik | Opt-in automated corpse looting using server-defined profiles. |
| [Bank-Enhanced](https://github.com/FtuoilXelrash/Bank-Enhanced) | FtuoilXelrash | Adds banking for items, currency, and luminance. |
| [CustomClothingBase](https://github.com/OptimShi/CustomClothingBase) | OptimShi | Customizes server-side clothing tables and appearance options. |
| [FriendlyItemEnchants](https://github.com/derpymcgavn/FriendlyItemEnchants) | derpymcgavn | Allows beneficial item enchantments to target another player's equipped armor, clothing, and shields. |
| [Loremaster](https://github.com/Raajik/Loremaster) | Raajik | Adds quest-based bonus progression to experience rewards. |
| [NoBurden](https://github.com/FtuoilXelrash/ACE.Mod.NoBurden) | FtuoilXelrash | Disables encumbrance penalties for characters at or below a configurable level. |
| [RCON](https://github.com/FtuoilXelrash/ACE.Mod.RCON) | FtuoilXelrash | Remote ACE server administration through an RCON service and web interface. Review network exposure and authentication before enabling. |

## ACEmulator organization extensions

These projects are published under the [ACEmulator GitHub organization](https://github.com/ACEmulator). They are listed separately from third-party community projects.

| Project | Purpose |
| --- | --- |
| [ACE.Mods.Metrics](https://github.com/ACEmulator/ACE.Mods.Metrics) | Prometheus metrics exporter for ACE servers. |
| [ACE.Mods.WebAPI](https://github.com/ACEmulator/ACE.Mods.WebAPI) | RESTful API integration for ACE servers. |

## Mod development frameworks and examples

The [ACE Modding Wiki](https://github.com/ACEmulator/ACE/wiki/Modding) provides background on modifying ACE. The [ACE.BaseMod](https://github.com/aquafir/ACE.BaseMod) repository contains Harmony-based examples and is also available as an [ACEmulator organization fork](https://github.com/ACEmulator/ACE.BaseMod).

| Example / resource | Purpose |
| --- | --- |
| [ACE.BaseMod samples](https://github.com/aquafir/ACE.BaseMod/tree/master/Samples) | Collection of mod examples and starter implementations. |
| [ConnectionLimit](https://github.com/aquafir/ACE.BaseMod/tree/master/Samples/ConnectionLimit) | Sample connection-limit behavior. |
| [CustomSpells](https://github.com/aquafir/ACE.BaseMod/tree/master/Samples/CustomSpells) | Example custom spell functionality. |
| [EasyEnlightenment](https://github.com/aquafir/ACE.BaseMod/tree/master/Samples/EasyEnlightenment) | Example enlightenment-related changes. |
| [Raise](https://github.com/aquafir/ACE.BaseMod/tree/master/Samples/Raise) | Alternate leveling / progression example. |
| [Tower samples](https://github.com/aquafir/ACE.BaseMod/tree/master/Samples/Tower) | Collection of mod examples; not a single turnkey mod. |
| [HelloWorld](https://github.com/FtuoilXelrash/ACE.Mod.HelloWorld) | Example mod that greets players on login. |

**Note:** Sample code may require updates to work against current ACE builds. It is not necessarily packaged or maintained as a release-ready mod.

## Related projects (not drop-in ACE mods)

| Project | Purpose |
| --- | --- |
| [ACRealms.WorldServer](https://github.com/ACRealms/ACRealms.WorldServer) | ACE-derived world server with instancing and custom rulesets; an alternative server project, not an ACE mod. |
| [AC WorldBuilder](https://github.com/Chorizite/WorldBuilder) | Desktop application for creating and editing Asheron's Call DAT content; a development tool, not a server mod. |

## Suggesting an addition or correction

Contributions and corrections are welcome. Before proposing an entry:

1. Confirm the GitHub repository is publicly accessible and directly relevant to ACE.
2. Provide the project name, maintainer, URL, and a one-sentence description supported by the project's documentation.
3. Include compatibility requirements and download/release information **only when the maintainer documents them**.
4. Identify whether the project is an installable server mod, sample/framework, or related tool; do not mix unrelated game plugins into the directory.
5. Submit a documentation pull request or [open an issue](https://github.com/ACEmulator/ACE/issues) suggesting the change.

Projects do not need compiled releases to be listed, but a public source repository is required for this directory. Maintainers can request corrections or removal of their listings.

## Related ACE documentation

- [Hosting ACE](https://github.com/ACEmulator/ACE/wiki/ACE-Hosting)
- [ACE Modding Wiki](https://github.com/ACEmulator/ACE/wiki/Modding)
- [ACEmulator GitHub organization](https://github.com/ACEmulator)

*Initial entries were gathered from public GitHub repositories and references shared in the ACEmulator Discord community. Discord references do not by themselves constitute compatibility validation.*
