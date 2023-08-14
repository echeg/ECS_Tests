using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System391 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component188,Component172,Component128> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component45>())
   {
    entity.Del<Component45>();
   }
   else
   {
    entity.Replace(new Component45());
   }
  }
 }
}

}