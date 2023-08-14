using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System291 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component68,Component476> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component79>())
   {
    entity.Del<Component79>();
   }
   else
   {
    entity.Replace(new Component79());
   }
  }
 }
}

}
