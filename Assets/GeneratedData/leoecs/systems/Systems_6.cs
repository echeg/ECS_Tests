using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System6 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component117,Component259> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component27>())
   {
    q+=1;
    var com = entity.Get<Component27>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component36>())
   {
    q+=1;
    var com = entity.Get<Component36>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component248>())
   {
    q+=1;
    var com = entity.Get<Component248>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component38>())
   {
    q+=1;
    var com = entity.Get<Component38>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
