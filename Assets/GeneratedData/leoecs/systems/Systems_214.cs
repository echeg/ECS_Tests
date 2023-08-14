using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System214 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component427> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component311>())
   {
    entity.Del<Component311>();
   }
   else
   {
    entity.Replace(new Component311());
   }
  }
 }
}

}
