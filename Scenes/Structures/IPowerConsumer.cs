using System;
using ProjectManufactory.Scenes.Components;

namespace ProjectManufactory;

public interface IPowerConsumer
{
    PowerConsumerComponent PowerConsumerComponent { get; }
}
