using System;
using System.Collections.Generic;
using Godot;
using ProjectManufactory.Scenes.Structures;

namespace ProjectManufactory;

public class Network
{
    public List<INetworked> Participants { get; private set; } = new();

    public void Register(INetworked participant)
    {
        if (Participants.Contains(participant))
        {
            GD.PrintErr("Network already contains participant");
            return;
        }
            
        Participants.Add(participant);
    }

    public void Unregister(INetworked participant)
    {
        if (!Participants.Contains(participant))
        {
            GD.PrintErr("Network does not contain participant");
            return;
        }
            
        Participants.Remove(participant);
    }

    public void MigrateAll(Network targetNetwork)
    {
        foreach (var participant in Participants)
        {
            targetNetwork.Register(participant);
        }
        Participants.Clear();
    }
}
