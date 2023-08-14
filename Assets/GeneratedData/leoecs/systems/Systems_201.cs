using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System201 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component466,Component329> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component326>())
   {
    entity.Del<Component326>();
   }
   else
   {
    entity.Replace(new Component326());
   }
  }
 }
}

}
