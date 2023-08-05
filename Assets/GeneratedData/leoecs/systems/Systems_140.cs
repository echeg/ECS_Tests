using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System140 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component136,Component78> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component169>())
   {
    entity.Del<Component169>();
   }
   else
   {
    entity.Replace(new Component169());
   }
  }
 }
}

}
