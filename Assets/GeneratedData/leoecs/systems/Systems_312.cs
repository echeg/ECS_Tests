using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System312 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component318,Component296,Component165> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component342>())
   {
    entity.Del<Component342>();
   }
   else
   {
    entity.Replace(new Component342());
   }
  }
 }
}

}
