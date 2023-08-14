using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System200 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component389> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component71>())
   {
    entity.Del<Component71>();
   }
   else
   {
    entity.Replace(new Component71());
   }
  }
 }
}

}
