using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System158 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component208,Component480,Component153> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component255>())
   {
    entity.Del<Component255>();
   }
   else
   {
    entity.Replace(new Component255());
   }
  }
 }
}

}
