using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System59 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component168,Component97,Component40,Component490> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var e = _world.NewEntity();
   e.Replace(new TicksCooldownComponent(10));
   e.Replace(new Component4());
  }
 }
}

}
