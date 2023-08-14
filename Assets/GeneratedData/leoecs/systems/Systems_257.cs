using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System257 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component186,Component319,Component318> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component126>())
   {
    entity.Del<Component126>();
   }
   else
   {
    entity.Replace(new Component126());
   }
  }
 }
}

}
