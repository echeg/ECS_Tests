using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System80 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component143,Component324> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component482>())
   {
    q+=1;
    var com = entity.Get<Component482>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component447>())
   {
    q+=1;
    var com = entity.Get<Component447>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component161>())
   {
    q+=1;
    var com = entity.Get<Component161>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component294>())
   {
    q+=1;
    var com = entity.Get<Component294>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
