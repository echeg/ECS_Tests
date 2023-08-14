using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System388 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component110,Component270,Component204> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component141>())
   {
    entity.Del<Component141>();
   }
   else
   {
    entity.Replace(new Component141());
   }
  }
 }
}

}
