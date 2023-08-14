using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System212 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component374,Component349,Component127,Component480> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component424>())
   {
    entity.Del<Component424>();
   }
   else
   {
    entity.Replace(new Component424());
   }
  }
 }
}

}
