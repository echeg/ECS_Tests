using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System235 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component55,Component30,Component485,Component280> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component22());
  }
 }
}

}
