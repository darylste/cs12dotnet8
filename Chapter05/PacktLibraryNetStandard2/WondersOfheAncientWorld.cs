﻿namespace Packt.Shared;

[Flags]
public enum WondersOfheAncientWorld : byte
{
  None = 0b_0000_0000,
  GreatPyramidOfGiza = 0b_0000_0001, //i.e. 0
  HangingGardensOfBabylon = 0b_0000_0010, // i.e. 2
  StatueOfZuesAtOlympia = 0b_0000_0100, // i.e. 4
  TempleOfArtemisAtEphesus = 0b_0000_1000, // i.e. 8
  MausoleumAtHalicarnassus = 0b_0001_0000, // i.e. 16
  ColossusOfRhodes = 0b_0010_0000, // i.e. 32
  LighthouseOfAlexandria = 0b_0100_0000 // i.e. 64
}
