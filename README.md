# BattleNetApi
A .NET C# Library for the battle.net community API.

This library aims to provide an asynchronous wrapper for the battle.net community APIs.

Feel free to fork and submit pull requests for new features. Please see the coding guidelines at the bottom.

You can find more information on the API here: https://dev.battle.net.

You need a Mashery account and API key to work with the API.

## TL;DR Examples
The API usage is quite simple. Just create an instance of the ApiClient:
```
var client = new ApiClient("YOUR_API_KEY");
```
You may provide an optional instance of an ApiClientConfiguration object, include region and locale (defaults to US/en_US).
```
var client = new ApiClient("YOUR_API_KEY", new ApiClientConfiguration(Region.EU, Locale.en_GB));
```

Then just get the data you need. For example get all realms:
```
client.GetRealmStatusList()
```
Which returns an instance of a RealmList object, containing a list of all realms (`Realms`), and a list of realms narrowed down to only return one realm for each connected realm group (`ConnectedRealms`).

To get the current auction data, just use:
```
client.GetAuctionData("realm-name")
```
The actual auction data is not directly received. Instead the `Auctions` property on `AuctionFile` objects lazy loads this data when accessed. The lazy loading takes place in some kind of "Download Manager", which limits the maximum concurrent number of downloads. The number of concurrent downloads is soon to be configurable.

For a detailed documentation of all features, see the [Wiki](https://github.com/GrunowIT/BattleNetApi/wiki).

## API implementations
The following is a list taken from the battle.net API documentation, displaying which endpoint is implemented so far.

### D3 Community API
#### Profile API
- [ ] Career Profile
- [ ] Hero Profile

#### Data Resources
- [ ] Item Data
- [ ] Follower Data
- [ ] Artisan Data

### SC2 Community API
#### Profile API
- [ ] Profile
- [ ] Ladders
- [ ] Match History

#### Ladder API
- [ ] Ladder

#### Data Resources
- [ ] Achievements
- [ ] Rewards

### WoW Community API
#### Achievement API
- [ ] Achievement

#### Auction API
- [x] Auction API

#### Boss API
- [ ] Boss API (Models created)

#### Challenge Mode API
- [x] Realm Leaderboard
- [ ] Region Leaderboard

#### Character Profile API
- [ ] Character Profile (Models created)
- [ ] Achievements (Models created)
- [ ] Appearance (Models created)
- [ ] Feed (Models created)
- [ ] Guild (Models created)
- [ ] Hunter Pets (Models created)
- [ ] Items (Models created)
- [ ] Mounts (Models created)
- [ ] Pets (Models created)
- [ ] Pet Slots (Models created)
- [ ] Professions (Models created)
- [ ] Progression (Models created)
- [ ] PvP (Models created)
- [ ] Quests
- [ ] Reputation
- [ ] Statistics
- [ ] Stats
- [ ] Talnets
- [ ] Titles
- [ ] Audit

#### Guild Profile API
- [ ] Guild Profile
- [ ] Members
- [ ] Achievements
- [ ] News
- [ ] Challenge

#### Item API
- [x] Item (Based on like 10 different items, might still be missing some fields in the model)
- [x] Item Set

#### Mount API
- [ ] Master List

#### Pet API
- [ ] Master List
- [ ] Abilities
- [ ] Species
- [ ] Stats

#### PvP API
- [ ] Leaderboards

#### Quest API
- [ ] Quest

#### Realm Status API
- [x] Realm Status

#### Recipe API
- [x] Recipe

#### Spell API
- [x] Spell

#### Zone API
- [x] Master List
- [x] Zone

#### Data Resources
- [x] Battlegroups
- [x] Character Races
- [x] Character Classes
- [x] Character Achievements
- [x] Guild Rewards
- [x] Guild Perks
- [x] Guild Achievements
- [x] Item Classes
- [x] Talents
- [x] Pet Types

## Coding Guidelines
I'm not too strict about coding styles. Just keep a few things in mind when developing for this BattleNetApi project:
* Take a look at the current architecture, see through the classes, understand the pattern, contribute.
* Do not use `dynamic`s.
* Provide sync and async interfaces for newly implemented API endpoints.

