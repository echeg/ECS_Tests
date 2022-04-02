using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System2 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component292,Component51,Component405,Component286> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component396());
  }
 }
}

}
