

using RockScissorsPaperSimulation;

RockScissorsPaperGame simulator = new RockScissorsPaperGame(new PlayerOnRock(),
                                                            new PlayerOnRandom(),
                                                            new ConsoleLogger());

simulator.Simulate(100);
Console.ReadKey();