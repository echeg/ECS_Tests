using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System350 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component378,Component49,Component415,Component79> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component199>())
   {
    entity.Del<Component199>();
   }
   else
   {
    entity.Replace(new Component199());
   }
  }
 }
}

}
