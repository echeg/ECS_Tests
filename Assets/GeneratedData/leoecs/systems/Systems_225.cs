using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System225 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component264,Component496,Component173,Component7> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component407());
  }
 }
}

}
