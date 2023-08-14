using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System393 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component448,Component339> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component93>())
   {
    entity.Del<Component93>();
   }
   else
   {
    entity.Replace(new Component93());
   }
  }
 }
}

}
