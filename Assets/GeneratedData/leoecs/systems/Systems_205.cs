using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System205 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component23,Component433,Component60,Component240> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component373());
  }
 }
}

}
