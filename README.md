# TsuTsuTsu-Tsunami

__A.k.a DH2323 project Lava Lamp__

Unity version used: 2018.3.11f1

In this project we took a unity C# script for metaballs and modified it to create a lava lamp.
In the original script there was only functionality for setting the blobs rendering positions.
We solved this by creating an array of gameobjects with sphere colliders that the rendered blobs followed.
This way we could control the blobs in a more suiting way.

The goal was to make the lava act realisticly by only changing one factor: __The temperature__.

In our implementation we've tried to take realistic steps to reach this.

1. Temperature affects each blobs radius depending on their distance from the heat source (the bottom)
2. The radius is affected by the temperature
3. The density is affected by the radius
4. The force applied on each blob is affected by the density
5. The blob's position is affected by the force.

[Link to project blog](http://sabinavonessen.me/blog/)
