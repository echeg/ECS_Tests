using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System82 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component255,Component452> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component24>())
   {
    q+=1;
    var com = entity.Get<Component24>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component490>())
   {
    q+=1;
    var com = entity.Get<Component490>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component141>())
   {
    q+=1;
    var com = entity.Get<Component141>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component306>())
   {
    q+=1;
    var com = entity.Get<Component306>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
