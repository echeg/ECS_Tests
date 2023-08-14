using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System308 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component35> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component132>())
   {
    entity.Del<Component132>();
   }
   else
   {
    entity.Replace(new Component132());
   }
  }
 }
}

}