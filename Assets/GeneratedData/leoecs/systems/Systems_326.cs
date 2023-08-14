using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System326 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component384,Component380,Component65,Component163> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component20>())
   {
    entity.Del<Component20>();
   }
   else
   {
    entity.Replace(new Component20());
   }
  }
 }
}

}
