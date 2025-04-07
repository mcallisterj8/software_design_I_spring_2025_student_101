﻿Box<string> boxA = new Box<string> {
    Name = "BoxA",
    FeaturedItem = "Star Item"
};

boxA.ItemList.AddRange(
    new List<string> {"apple", "berry", "cherry"}
);

Box<iPhone> boxB = new Box<iPhone> {
    Name = "BoxB",
    FeaturedItem = new iPhone { Name = "phoneA" },
};

boxB.ItemList.AddRange(
    new List<iPhone> {
        new iPhone { Name = "phoneB" },
        new iPhone { Name = "phoneC" },
        new iPhone { Name = "phoneD" }
    }
);

Console.WriteLine("\n");
Console.WriteLine($"{boxA}");
Console.WriteLine("\n");

Console.WriteLine("\n");
Console.WriteLine($"{boxB}");
Console.WriteLine("\n");