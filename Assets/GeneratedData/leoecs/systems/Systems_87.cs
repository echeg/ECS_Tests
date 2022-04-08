using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System87 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component119,Component101> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component126>())
   {
    q+=1;
    var com = entity.Get<Component126>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component346>())
   {
    q+=1;
    var com = entity.Get<Component346>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component104>())
   {
    q+=1;
    var com = entity.Get<Component104>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component90>())
   {
    q+=1;
    var com = entity.Get<Component90>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
