using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System170 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component187> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component39>())
   {
    entity.Del<Component39>();
   }
   else
   {
    entity.Replace(new Component39());
   }
  }
 }
}

}
