using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System11 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component24,Component364,Component275,Component207> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component280());
  }
 }
}

}
