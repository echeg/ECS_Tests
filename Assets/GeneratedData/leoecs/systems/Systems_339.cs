using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System339 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component294,Component93,Component6,Component66> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component276>())
   {
    entity.Del<Component276>();
   }
   else
   {
    entity.Replace(new Component276());
   }
  }
 }
}

}
