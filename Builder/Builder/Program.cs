using Builder;

NPCBuilder builder = new();
Director director = new(builder);

director.BuildDefaultNPC();
NPCBuilder defaultNPC = builder.GetNPC();
defaultNPC.Build();

director.BuildCustomNPC("Alice", 50, 100, 10);
NPCBuilder customNPC = builder.GetNPC();
customNPC.Build();