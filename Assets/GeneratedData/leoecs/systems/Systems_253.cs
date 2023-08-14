using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System253 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component402,Component66,Component374,Component231> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component381>())
   {
    entity.Del<Component381>();
   }
   else
   {
    entity.Replace(new Component381());
   }
  }
 }
}

}
