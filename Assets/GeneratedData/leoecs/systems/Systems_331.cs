using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System331 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component448,Component414,Component185> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component290>())
   {
    entity.Del<Component290>();
   }
   else
   {
    entity.Replace(new Component290());
   }
  }
 }
}

}
