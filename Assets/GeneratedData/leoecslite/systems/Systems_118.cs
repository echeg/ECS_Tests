using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System118 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component243> _p1;
EcsPool<Component14> _p2;
EcsPool<Component370> _p3;
EcsPool<Component284> _p4;
EcsPool<Component491> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component243>().Inc<Component14>().Inc<Component370>().Inc<Component284>().End();
   _p1 = _world.GetPool<Component243>();
   _p2 = _world.GetPool<Component14>();
   _p3 = _world.GetPool<Component370>();
   _p4 = _world.GetPool<Component284>();
   _pl0 = _world.GetPool<Component491>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
