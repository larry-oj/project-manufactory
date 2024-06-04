using System;
using ProjectManufactory.Scenes.Components;

namespace ProjectManufactory.Scenes.Structures;

public interface INetworked
{
    NetworkComponent NetworkComponent { get; }
}
