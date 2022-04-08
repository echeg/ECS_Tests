using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System89 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component53,Component391,Component163> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component347>())
   {
    q+=1;
    var com = entity.Get<Component347>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component3>())
   {
    q+=1;
    var com = entity.Get<Component3>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component463>())
   {
    q+=1;
    var com = entity.Get<Component463>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component53>())
   {
    q+=1;
    var com = entity.Get<Component53>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
