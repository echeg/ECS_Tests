using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System152 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component384,Component343,Component90> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component298>())
   {
    entity.Del<Component298>();
   }
   else
   {
    entity.Replace(new Component298());
   }
  }
 }
}

}
