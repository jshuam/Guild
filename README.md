# Repository Guidelines
This README will serve as a list of guidelines to follow when contributing to this repository

### Table of Contents
1. [Managing Branches and Tags](#managing-branches-and-tags)
2. [Code Guidelines](#code-guidelines)
3. [Architectural Guidelines](#arch-guidelines)

## Managing Branches and Tags <a name="managing-branches-and-tags"></a>
* If possible always branch off of the **development** branch when working on a new feature
* Name your feature branches appropriately, e.g. **activity-framework** if working on the activity framework
* Always merge completed features into the **development** branch
* Only merge into **master** from **development** when all features in a version are complete
* Once a version has been merged into **master** use git tag to tag a commit as a completed version
  * ```git tag 0.1.0``` this will tag the current **HEAD** commit on your current branch
  * ```git push origin 0.1.0``` this will push a tag to origin
* Only tag commits on **master** once a version has been completely finished and merged

## Code Guidelines <a name="code-guidelines"><a/>
* If ever in doubt make sure to refer to Microsoft's C# documentation
* **Comment your code**
* Use camelCase for fields
* Use PascalCase for properties
* Always use properties over public fields
* If you find yourself writing a getter/setter, replace it with a property
* Properties in Unity must be written the old fashioned way with a backing private field, e.g.
  ```csharp
  [SerializeField]
  private _currentHealth
  public CurrentHealth { get => _currentHealth; set => _currentHealth = value }
  ```
* Use read only properties when a value shouldn't change at runtime, e.g.
  ```csharp
  private _currentHealth
  public CurrentHealth { get => _currentHealth; }
  ```
* Prefix **private fields** with an underscore, e.g. ```_privateField```

## Architectural Guidelines <a name="arch-guidelines"></a>
* Ensure that all code is written in a component focused way
    * Code written for an enemy should not be written in an enemy class. Rather an enemy should be a saved prefab with multiple components attached, e.g. health, AI, sprite, etc.
* Keep a logical folder layout and be as specific as possible with hierarchies
* If a GameObject will need multiple components, split it into logical parts, e.g.
    * Empty GameObject titled 'Player'
    * GameObject within titled 'Movement' that contains all scripts for player movement, etc.
