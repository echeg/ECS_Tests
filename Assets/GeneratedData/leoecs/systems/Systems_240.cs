using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System240 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component202,Component259,Component244,Component292> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component92());
  }
 }
}

}
