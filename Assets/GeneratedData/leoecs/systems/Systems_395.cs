using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System395 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component127,Component134,Component345,Component122> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component27>())
   {
    entity.Del<Component27>();
   }
   else
   {
    entity.Replace(new Component27());
   }
  }
 }
}

}
