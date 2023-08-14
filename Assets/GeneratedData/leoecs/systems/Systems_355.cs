using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System355 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component242,Component33,Component24> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component339>())
   {
    entity.Del<Component339>();
   }
   else
   {
    entity.Replace(new Component339());
   }
  }
 }
}

}
